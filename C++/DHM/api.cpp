#include "pch.h"
#include "api.h"
#include "DH.h"
#include <iostream>
#include <opencv2/core.hpp>
using namespace cv;
using namespace std;

Mat InputImage;
void convertMat2CS(cv::Mat src, uchar* ptr, int* length) {
    ptr = src.data;
    *length = src.total() * src.elemSize();
}


LIB_API  void __stdcall  imageini(unsigned char* src, int w, int h, int ch) 
{
    if (ch == 1) {
       Mat srcImage(h, w, CV_8UC1, src);
       srcImage.copyTo(InputImage);
    }
    else if (ch ==2)
    {
        Mat srcImage(h, w, CV_8UC2, src);
        cvtColor(srcImage, srcImage, COLOR_BGR2GRAY);
        srcImage.copyTo(InputImage);

    }
    else if (ch == 3) {
        Mat srcImage(h, w, CV_8UC3, src);
        cvtColor(srcImage, srcImage, COLOR_BGR2GRAY);
        srcImage.copyTo(InputImage);
    }
    else {
        Mat srcImage(h, w, CV_8UC4, src);
        cvtColor(srcImage, srcImage, COLOR_BGR2GRAY);
        srcImage.copyTo(InputImage);
    }
}

void OutputImage(Mat mat, uchar* ptr, int* len) {
    Mat out;
    normalize(mat, out, 0, 255, NORM_MINMAX);
    convertMat2CS(out, ptr, len);
}
Mat fft_DH, fft_magnitude;

LIB_API  void __stdcall  imagefft(uchar* ptr, int* len) {

    fft2(InputImage, fft_DH, fft_magnitude);
    fftshift(fft_DH);
    OutputImage(fft_magnitude, ptr, len);
 }
Mat ifft_DH, sample_phi;
LIB_API  void __stdcall  imagesample(uchar* ptr, int* len) {
    Mat sample,sample_phi, sample_norm;

    AutoSpectrumSelection(fft_DH, fft_magnitude, sample, 0.5, 4.4, 20.0, 0.532);
    ifftshift(sample);
    ifft2(sample, ifft_DH);
    phi_angle(ifft_DH, sample_phi);
    normalize(sample_phi, sample_norm, 0, 1, NORM_MINMAX);
    OutputImage(sample_phi, ptr, len);
}

Mat DH_phi, DH_Inten, DH;

LIB_API  void __stdcall  imagepca(uchar* ptr, int* len) {
    Mat sample, sample_phi, sample_norm;

    AutoSpectrumSelection(fft_DH, fft_magnitude, sample, 0.5, 4.4, 20.0, 0.532);
    //ifftshift(sample);
    //ifft2(sample, ifft_DH);
    //phi_angle(ifft_DH, sample_phi);
    //normalize(sample_phi, sample_norm, 0, 1, NORM_MINMAX);
    //phase_PCA(ifft_DH, sample_phi, DH_phi, DH_Inten, DH);

    Mat MatR0, MatI0;
    Mat planes[] = { Mat::zeros(fft_DH.size(), CV_32F), Mat::zeros(fft_DH.size(), CV_32F) };
    split(sample, planes);
    planes[0].copyTo(MatR0);
    planes[1].copyTo(MatI0);

    //PCA Compensation
    float nw0, nh0, nw, nh, c1, c2;
    nw0 = 125;
    nh0 = 100;
    nw = MatR0.cols;
    nh = MatR0.rows;
    c1 = (nw0 - 1) / (nw - 1);
    c2 = (nh0 - 1) / (nh - 1);
    Mat MatR, MatI, result, complex_PCA;
    MatR0(Rect((nw - nw0) / 2, (nh - nh0) / 2, nw0, nh0)).copyTo(MatR);
    MatI0(Rect((nw - nw0) / 2, (nh - nh0) / 2, nw0, nh0)).copyTo(MatI);
    Mat planes_PCA[] = { Mat::zeros(MatR.rows, MatR.cols, CV_64FC1), Mat::zeros(MatR.rows, MatR.cols, CV_64FC1) };
    MatR.copyTo(planes_PCA[0]);
    MatI.copyTo(planes_PCA[1]);
    merge(planes_PCA, 2, complex_PCA);
    ifftshift(complex_PCA);
    ifft2(complex_PCA, ifft_DH);
    phi_angle(ifft_DH, sample_phi);
    normalize(sample_phi, sample_norm, 0, 1, NORM_MINMAX);
    Mat sample_PCA, sample_PCA_norm, ifft_sample;
    ifftshift(sample);
    ifft2(sample, ifft_sample);
    phi_angle(ifft_sample, sample_PCA);
    normalize(sample_PCA, sample_PCA_norm, 0, 1, NORM_MINMAX);

    Mat DH_PCA;
    Mat E, E_conj, ifft_PCA;
    get_exp(sample_phi, E);
    E_SVD(E, sample_PCA, E_conj, c1, c2);
    Multiple(ifft_sample, E_conj, DH);
    phi_angle(DH, DH_phi);
    Inten(DH, DH_Inten);
    normalize(DH_phi, DH_PCA, 0, 1, NORM_MINMAX);

    OutputImage(DH_phi, ptr, len);
}   
Mat DH_phi1;
LIB_API  void __stdcall  imageunwrap(int UnwrapMode, uchar* ptr, int* len) {
    DH_phi.copyTo(DH_phi1);
    phase_unwrap(UnwrapMode, DH_phi1);
    OutputImage(DH_phi1, ptr, len);
}
Mat phi, phi_norm, phi_norm1, phi_mean, phi_std, phi_bi, phi_nlm, phi_bm3d, phi_DIC;

LIB_API  void __stdcall  imagedic(uchar* ptr, int* len) {

    normalize(DH_phi1, phi_norm, 0, 1, NORM_MINMAX);
    resize(DH_phi1, phi, Size(1600, 1200), 0, 0, INTER_CUBIC);
    resize(DH_Inten, DH_Inten, Size(1600, 1200), 0, 0, INTER_LINEAR);

    meanStdDev(phi, phi_mean, phi_std);
    phi = phi - phi_mean;

    //DIC
    float rotation = 0.75;
    float distance = 2.00;
    DIC_matcalculate(phi, phi_DIC, rotation, distance);
    OutputImage(phi_DIC, ptr, len);

}

LIB_API  void __stdcall  imageHistCalc(uchar* ptr, int* len) {
    float lowActive = -10;
    float highActive = 20;
    double pha_min = 0;
    double pha_max = 0;

    HistCalc(phi, lowActive, highActive, pha_min, pha_max);
    OutputImage(phi, ptr, len);
}










LIB_API  void __stdcall inference3(unsigned char* src, int w, int h, int ch, uchar* ptr, int* len)
{
    int format;

    switch (ch)
    {
    case 1: format = CV_8UC1; break;

    case 2: format = CV_8UC2; break;
    case 3: format = CV_8UC3; break;
    default: format = CV_8UC4; break;
    }
    Mat srcImage(h, w, format, src);

    switch (ch)
    {
        case 1:
            format = CV_8UC1; break;
        case 2: 
            format = CV_8UC2;
            cvtColor(srcImage, srcImage, COLOR_BGR2GRAY);
            break;
        case 3: 
            format = CV_8UC3; 
            cvtColor(srcImage, srcImage, COLOR_BGR2GRAY);
            break;
        default: 
            format = CV_8UC4; 
            cvtColor(srcImage, srcImage, COLOR_BGR2GRAY);
            break;
    }


    fft2(srcImage, fft_DH, fft_magnitude);
    fftshift(fft_DH);
    Mat sample;
    AutoSpectrumSelection(fft_DH, fft_magnitude, sample, 0.5, 4.4, 20.0, 0.532);

    normalize(fft_magnitude, fft_magnitude, 0, 255, NORM_MINMAX);
    convertMat2CS(fft_magnitude, ptr, len);
}



LIB_API  void __stdcall  inference4(unsigned char* src, int w, int h, int ch, uchar* ptr, int* len) 
{
    int format;
    switch (ch)
    {
    case 1: format = CV_8UC1; break;
    case 2: format = CV_8UC2; break;
    case 3: format = CV_8UC3; break;
    default: format = CV_8UC4; break;
    }
    Mat srcImage(h, w, format, src);
    fft2(srcImage, fft_DH, fft_magnitude);
    fftshift(fft_DH);
    Mat sample, ifft_DH, sample_phi, sample_norm;
    AutoSpectrumSelection(fft_DH, fft_magnitude, sample, 0.5, 4.4, 20.0, 0.532);
    ifftshift(sample);
    ifft2(sample, ifft_DH);
    phi_angle(ifft_DH, sample_phi);
    normalize(sample_phi, sample_norm, 0, 1, NORM_MINMAX);

    normalize(sample_norm, sample_norm, 0, 255, NORM_MINMAX);
    convertMat2CS(sample_norm, ptr, len);
}



LIB_API  void __stdcall  inference5(unsigned char* src, int w, int h, int ch, uchar* ptr, int* len)
{
    int format;

    switch (ch)
    {
    case 1: format = CV_8UC1; break;
    case 2: format = CV_8UC2; break;
    case 3: format = CV_8UC3; break;
    default: format = CV_8UC4; break;
    }
    Mat srcImage(h, w, format, src);
    fft2(srcImage, fft_DH, fft_magnitude);
    fftshift(fft_DH);
    Mat sample, ifft_DH, sample_phi, sample_norm;
    AutoSpectrumSelection(fft_DH, fft_magnitude, sample, 0.5, 4.4, 20.0, 0.532);
    ifftshift(sample);
    ifft2(sample, ifft_DH);
    phi_angle(ifft_DH, sample_phi);

    normalize(sample_phi, sample_norm, 0, 1, NORM_MINMAX);

    phase_PCA(ifft_DH, sample_phi, DH_phi, DH_Inten, DH);
    Mat out = DH_phi.clone();
    normalize(out, out, 0, 255, NORM_MINMAX);
    convertMat2CS(out, ptr, len);
}


LIB_API  void __stdcall  inference6(int UnwrapMode, uchar* ptr, int* len)
{
    Mat DH_phi1 = DH_phi.clone();

    //Phase unwrap
    phase_unwrap(UnwrapMode, DH_phi1);
    normalize(DH_phi1, DH_phi1, 0, 1, NORM_MINMAX);

    normalize(DH_phi1, DH_phi1, 0, 255, NORM_MINMAX);
    convertMat2CS(DH_phi1, ptr, len);

}


LIB_API  void __stdcall  inference7(int UnwrapMode, uchar* ptr, int* len)
{
    Mat DH_phi1 = DH_phi.clone();
    Mat phi, phi_norm, phi_norm1, phi_mean, phi_std, phi_bi, phi_nlm, phi_bm3d, phi_DIC;

    phase_unwrap(UnwrapMode, DH_phi1);

    normalize(DH_phi1, phi_norm, 0, 1, NORM_MINMAX);
    resize(DH_phi1, phi, Size(1600, 1200), 0, 0, INTER_CUBIC);
    resize(DH_Inten, DH_Inten, Size(1600, 1200), 0, 0, INTER_LINEAR);

    meanStdDev(phi, phi_mean, phi_std);
    phi = phi - phi_mean;

    //DIC
    float rotation = 0.75;
    float distance = 2.00;
    DIC_matcalculate(phi, phi_DIC, rotation, distance);

    normalize(phi_DIC, phi_DIC, 0, 255, NORM_MINMAX);
    convertMat2CS(phi_DIC, ptr, len);
}

LIB_API  void __stdcall  inference8(int UnwrapMode, uchar* ptr, int* len)
{
    Mat DH_phi1 = DH_phi.clone();
    Mat phi, phi_norm, phi_norm1, phi_mean, phi_std, phi_bi, phi_nlm, phi_bm3d, phi_DIC;

    phase_unwrap(UnwrapMode, DH_phi1);
    normalize(DH_phi1, phi_norm, 0, 1, NORM_MINMAX);
    resize(DH_phi1, phi, Size(1600, 1200), 0, 0, INTER_CUBIC);
    resize(DH_Inten, DH_Inten, Size(1600, 1200), 0, 0, INTER_LINEAR);

    meanStdDev(phi, phi_mean, phi_std);
    phi = phi - phi_mean;

    //DIC
    float rotation = 0.75;
    float distance = 2.00;
    DIC_matcalculate(phi, phi_DIC, rotation, distance);

    float lowActive = -10;
    float highActive = 20;
    double pha_min = 0;
    double pha_max = 0;

    HistCalc(phi, lowActive, highActive, pha_min, pha_max);
    normalize(phi, phi_norm, 0, 1, NORM_MINMAX);
    normalize(phi_norm, phi_norm, 0, 255, NORM_MINMAX);
    convertMat2CS(phi_norm, ptr, len);
}



std::vector<uchar>* vec1 = new std::vector<uchar>;
std::vector<uchar>* vec2 = new std::vector<uchar>;
std::vector<uchar>* vec3 = new std::vector<uchar>;

Mat E, E_conj;

bool Fast = true;
int x12, y12, nw12, nh12;

LIB_API  void __stdcall imageall(unsigned char* src, int w, int h, int ch, int UnwrapMode, uchar* ptr, int* len, uchar* ptr1, int* len1, uchar* ptr2, int* len2)
{
    ///
    if (ch == 1) {
        Mat srcImage(h, w, CV_8UC1, src);
        srcImage.copyTo(InputImage);
    }
    else if (ch == 2)
    {
        Mat srcImage(h, w, CV_8UC2, src);
        cvtColor(srcImage, srcImage, COLOR_BGR2GRAY);
        srcImage.copyTo(InputImage);
    }
    else if (ch == 3) {
        Mat srcImage(h, w, CV_8UC3, src);
        cvtColor(srcImage, srcImage, COLOR_BGR2GRAY);
        srcImage.copyTo(InputImage);
    }
    else {
        Mat srcImage(h, w, CV_8UC4, src);
        cvtColor(srcImage, srcImage, COLOR_BGR2GRAY);
        srcImage.copyTo(InputImage);
    }

    //fft
#pragma region FFT
    Mat padded;                            //expand input image to optimal size
    int m = getOptimalDFTSize(InputImage.rows);
    int n = getOptimalDFTSize(InputImage.cols); // on the border add zero values
    copyMakeBorder(InputImage, padded, 0, m - InputImage.rows, 0, n - InputImage.cols, BORDER_CONSTANT, Scalar::all(0));
    Mat planes[] = { Mat_<float>(padded), Mat::zeros(padded.size(), CV_32F) };
    Mat complexI;
    merge(planes, 2, complexI);         // Add to the expanded another plane with zeros
    dft(complexI, complexI);            // this way the result may fit in the source matrix
    // compute the magnitude and switch to logarithmic scale
    // => log(1 + sqrt(Re(DFT(I))^2 + Im(DFT(I))^2))
    split(complexI, planes);                   // planes[0] = Re(DFT(I), planes[1] = Im(DFT(I))
    magnitude(planes[0], planes[1], planes[0]);// planes[0] = magnitude
    Mat magI = planes[0];
    magI += Scalar::all(1);                    // switch to logarithmic scale
    log(magI, magI);
    // crop the spectrum, if it has an odd number of rows or columns
    magI = magI(Rect(0, 0, magI.cols & -2, magI.rows & -2));
    // rearrange the quadrants of Fourier image  so that the origin is at the image center
    int cx = magI.cols / 2;
    int cy = magI.rows / 2;
    Mat q0(magI, Rect(0, 0, cx, cy));   // Top-Left - Create a ROI per quadrant
    Mat q1(magI, Rect(cx, 0, cx, cy));  // Top-Right
    Mat q2(magI, Rect(0, cy, cx, cy));  // Bottom-Left
    Mat q3(magI, Rect(cx, cy, cx, cy)); // Bottom-Right
    Mat tmp;                           // swap quadrants (Top-Left with Bottom-Right)
    q0.copyTo(tmp);
    q3.copyTo(q0);
    tmp.copyTo(q3);
    q1.copyTo(tmp);                    // swap quadrant (Top-Right with Bottom-Left)
    q2.copyTo(q1);
    tmp.copyTo(q2);

    fft_DH = complexI;
    fft_magnitude = magI;


    normalize(fft_magnitude, fft_magnitude, 0, 255, NORM_MINMAX);




    Size sz = fft_DH.size();
    Point pt((int)floor(sz.width / 2.0), (int)floor(sz.height / 2.0));
    circshift(fft_DH, pt);




    Mat sample, sample_A, MatR1, MatI1, ifft_DH, sample_norm;
    float NA = 0.25;
    float pixelsize = 4.4;
    float Ma = 10;
    float lamda = 0.532;
    
    if (Fast) {
        nw12 = (NA * 2 * pixelsize * InputImage.cols) / (lamda * Ma);
        nh12 = (NA * 2 * pixelsize * InputImage.rows) / (lamda * Ma);
        AutoSpectrumSelection(fft_DH, fft_magnitude, x12, y12, nw12, nh12);
        Rection(fft_DH, fft_magnitude, x12, y12, nw12, nh12, sample, sample_A);
    }
    else {
        Rection(fft_DH, fft_magnitude, x12, y12, nw12, nh12, sample, sample_A);
    }

    Mat MatR0, MatI0;
    Mat planes1[] = { Mat::zeros(fft_DH.size(), CV_32F), Mat::zeros(fft_DH.size(), CV_32F) };
    split(sample, planes1);
    planes1[0].copyTo(MatR0);
    planes1[1].copyTo(MatI0);

    Mat sample_PCA, sample_PCA_norm, ifft_sample;
    ifftshift(sample);
    idft(sample, ifft_sample);
    phi_angle(ifft_sample, sample_PCA);

    //PCA Compensation
    float nw0, nh0, nw, nh, c1, c2;
    nw0 = 250;
    nh0 = 200;
    nw = MatR0.cols;
    nh = MatR0.rows;

    Mat MatR, MatI, result, complex_PCA;
    MatR0(Rect((nw - nw0) / 2, (nh - nh0) / 2, nw0, nh0)).copyTo(MatR);
    MatI0(Rect((nw - nw0) / 2, (nh - nh0) / 2, nw0, nh0)).copyTo(MatI);
    Mat planes_PCA[] = { Mat::zeros(MatR.rows, MatR.cols, CV_64FC1), Mat::zeros(MatR.rows, MatR.cols, CV_64FC1) };
    MatR.copyTo(planes_PCA[0]);
    MatI.copyTo(planes_PCA[1]);
    merge(planes_PCA, 2, complex_PCA);

    ifftshift(complex_PCA);
    idft(complex_PCA, ifft_DH);
    phi_angle(ifft_DH, sample_phi);

    Mat DH_PCA;


    if (Fast)
    {
        c1 = (nw0 - 1) / (nw - 1);
        c2 = (nh0 - 1) / (nh - 1);

        get_exp(sample_phi, E);
        E_SVD(E, sample_PCA, E_conj, c1, c2);
        Multiple(ifft_sample, E_conj, DH);
        Fast = !Fast;
    }
    else
    {
        Multiple(ifft_sample, E_conj, DH);
    }

    phi_angle(DH, DH_phi);
    Inten(DH, DH_Inten);

    //DH_phiµÄ×î

    phase_unwrap(UnwrapMode, DH_phi);

    phi = DH_phi;
    meanStdDev(phi, phi_mean, phi_std);
    phi = phi - phi_mean;


    float lowActive = -10;
    float highActive = 20;
    double pha_min = 0;
    double pha_max = 0;

    Mat Phi1;
    phi.copyTo(Phi1);

    HistCalc(Phi1, lowActive, highActive, pha_min, pha_max);

    highActive = 9;
    normalize(Phi1, Phi1, 0, 255, NORM_MINMAX);


    resize(phi, phi, Size(1600, 1200), 0, 0, INTER_CUBIC);

    //resize(DH_Inten, DH_Inten, Size(1600, 1200), 0, 0, INTER_LINEAR);

    //DIC
    float rotation = 0.75;
    float distance = 2.00;

    DIC_matcalculate(phi, phi_DIC, rotation, distance);



    return;
}

LIB_API  void __stdcall speedtest(unsigned char* src, int w, int h, int ch, uchar** ptr, int* len) {
    Mat Frame;

    if (ch == 1) {
        Mat srcImage(h, w, CV_8UC1, src);
        Frame = srcImage;
    }
    else if (ch == 2)
    {
        Mat srcImage(h, w, CV_8UC2, src);
        //cvtColor(srcImage, srcImage, COLOR_BGR2GRAY);
        Frame = srcImage;
    }
    else if (ch == 3) {
        Mat srcImage(h, w, CV_8UC3, src);
        //cvtColor(srcImage, srcImage, COLOR_BGR2GRAY);
        Frame = srcImage;
    }
    else {
        Mat srcImage(h, w, CV_8UC4, src);
        //cvtColor(srcImage, srcImage, COLOR_BGR2GRAY);
        Frame = srcImage;
    }
    //normalize(InputImage, InputImage, 0, 255, NORM_MINMAX);

    //cv::imencode(".png", Frame, *vec3);
    int stp = 0;
    *ptr = Frame.data;
    *len = strlen((char*)Frame.data);

}


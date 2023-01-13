//
// File: watershed_matlab_emxAPI.h
//
// MATLAB Coder version            : 4.2
// C/C++ source code generated on  : 05-Jul-2022 17:23:29
//
#ifndef WATERSHED_MATLAB_EMXAPI_H
#define WATERSHED_MATLAB_EMXAPI_H

// Include Files
#include <stddef.h>
#include <stdlib.h>
#include "rtwtypes.h"
#include "watershed_matlab_types.h"

// Function Declarations
extern emxArray_real32_T *emxCreateND_real32_T(int numDimensions, int *size);
extern emxArray_real32_T *emxCreateWrapperND_real32_T(float *data, int
  numDimensions, int *size);
extern emxArray_real32_T *emxCreateWrapper_real32_T(float *data, int rows, int
  cols);
extern emxArray_real32_T *emxCreate_real32_T(int rows, int cols);
extern void emxDestroyArray_real32_T(emxArray_real32_T *emxArray);
extern void emxInitArray_real32_T(emxArray_real32_T **pEmxArray, int
  numDimensions);

#endif

//
// File trailer for watershed_matlab_emxAPI.h
//
// [EOF]
//

/*
 * File: _coder_Long_Short_axis_api.h
 *
 * MATLAB Coder version            : 4.2
 * C/C++ source code generated on  : 25-Dec-2021 11:04:43
 */

#ifndef _CODER_LONG_SHORT_AXIS_API_H
#define _CODER_LONG_SHORT_AXIS_API_H

/* Include Files */
#include "tmwtypes.h"
#include "mex.h"
#include "emlrt.h"
#include <stddef.h>
#include <stdlib.h>
#include "_coder_Long_Short_axis_api.h"

/* Type Definitions */
#ifndef struct_emxArray_real_T
#define struct_emxArray_real_T

struct emxArray_real_T
{
  real_T *data;
  int32_T *size;
  int32_T allocatedSize;
  int32_T numDimensions;
  boolean_T canFreeData;
};

#endif                                 /*struct_emxArray_real_T*/

#ifndef typedef_emxArray_real_T
#define typedef_emxArray_real_T

typedef struct emxArray_real_T emxArray_real_T;

#endif                                 /*typedef_emxArray_real_T*/

/* Variable Declarations */
extern emlrtCTX emlrtRootTLSGlobal;
extern emlrtContext emlrtContextGlobal;

/* Function Declarations */
extern void Long_Short_axis(emxArray_real_T *bw, emxArray_real_T
  *Long_axis_distance, emxArray_real_T *Short_axis_distance);
extern void Long_Short_axis_api(const mxArray * const prhs[1], int32_T nlhs,
  const mxArray *plhs[2]);
extern void Long_Short_axis_atexit(void);
extern void Long_Short_axis_initialize(void);
extern void Long_Short_axis_terminate(void);
extern void Long_Short_axis_xil_shutdown(void);
extern void Long_Short_axis_xil_terminate(void);

#endif

/*
 * File trailer for _coder_Long_Short_axis_api.h
 *
 * [EOF]
 */

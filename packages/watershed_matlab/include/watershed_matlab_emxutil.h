//
// File: watershed_matlab_emxutil.h
//
// MATLAB Coder version            : 4.2
// C/C++ source code generated on  : 05-Jul-2022 17:23:29
//
#ifndef WATERSHED_MATLAB_EMXUTIL_H
#define WATERSHED_MATLAB_EMXUTIL_H

// Include Files
#include <stddef.h>
#include <stdlib.h>
#include "rtwtypes.h"
#include "watershed_matlab_types.h"

// Function Declarations
extern void c_emxFreeStruct_images_internal(c_images_internal_coder_FifoPri
  *pStruct);
extern void c_emxInitStruct_images_internal(c_images_internal_coder_FifoPri
  *pStruct);
extern void emxEnsureCapacity_boolean_T(emxArray_boolean_T *emxArray, int
  oldNumel);
extern void emxEnsureCapacity_int32_T(emxArray_int32_T *emxArray, int oldNumel);
extern void emxEnsureCapacity_real32_T(emxArray_real32_T *emxArray, int oldNumel);
extern void emxEnsureCapacity_real_T(emxArray_real_T *emxArray, int oldNumel);
extern void emxEnsureCapacity_struct_T(emxArray_struct_T *emxArray, int oldNumel);
extern void emxEnsureCapacity_uint16_T(emxArray_uint16_T *emxArray, int oldNumel);
extern void emxFree_boolean_T(emxArray_boolean_T **pEmxArray);
extern void emxFree_int32_T(emxArray_int32_T **pEmxArray);
extern void emxFree_real32_T(emxArray_real32_T **pEmxArray);
extern void emxFree_real_T(emxArray_real_T **pEmxArray);
extern void emxFree_uint16_T(emxArray_uint16_T **pEmxArray);
extern void emxInit_boolean_T(emxArray_boolean_T **pEmxArray, int numDimensions);
extern void emxInit_int32_T(emxArray_int32_T **pEmxArray, int numDimensions);
extern void emxInit_real32_T(emxArray_real32_T **pEmxArray, int numDimensions);
extern void emxInit_real_T(emxArray_real_T **pEmxArray, int numDimensions);
extern void emxInit_uint16_T(emxArray_uint16_T **pEmxArray, int numDimensions);

#endif

//
// File trailer for watershed_matlab_emxutil.h
//
// [EOF]
//

//
// File: watershed_matlab_types.h
//
// MATLAB Coder version            : 4.2
// C/C++ source code generated on  : 04-Jan-2022 13:53:28
//
#ifndef WATERSHED_MATLAB_TYPES_H
#define WATERSHED_MATLAB_TYPES_H

// Include Files
#include "rtwtypes.h"

// Type Definitions
typedef struct {
  double priority;
  double value;
  double order;
} struct_T;

typedef struct {
  struct_T *data;
  int *size;
  int allocatedSize;
  int numDimensions;
  boolean_T canFreeData;
} emxArray_struct_T;

typedef struct {
  emxArray_struct_T *queueElements;
  double queueIndex;
  double queueOrder;
} c_images_internal_coder_FifoPri;

struct emxArray_boolean_T
{
  boolean_T *data;
  int *size;
  int allocatedSize;
  int numDimensions;
  boolean_T canFreeData;
};

struct emxArray_int32_T
{
  int *data;
  int *size;
  int allocatedSize;
  int numDimensions;
  boolean_T canFreeData;
};

struct emxArray_real_T
{
  double *data;
  int *size;
  int allocatedSize;
  int numDimensions;
  boolean_T canFreeData;
};

struct emxArray_uint16_T
{
  unsigned short *data;
  int *size;
  int allocatedSize;
  int numDimensions;
  boolean_T canFreeData;
};

#endif

//
// File trailer for watershed_matlab_types.h
//
// [EOF]
//

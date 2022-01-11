//
// File: Long_Short_axis_types.h
//
// MATLAB Coder version            : 4.2
// C/C++ source code generated on  : 25-Dec-2021 11:04:43
//
#ifndef LONG_SHORT_AXIS_TYPES_H
#define LONG_SHORT_AXIS_TYPES_H

// Include Files
#include "rtwtypes.h"

// Type Definitions
struct emxArray_real_T
{
  double *data;
  int *size;
  int allocatedSize;
  int numDimensions;
  boolean_T canFreeData;
};

typedef struct {
  emxArray_real_T *f1;
} cell_wrap_0;

typedef struct {
  double f1[4];
} cell_wrap_1;

struct emxArray_boolean_T
{
  boolean_T *data;
  int *size;
  int allocatedSize;
  int numDimensions;
  boolean_T canFreeData;
};

typedef struct {
  cell_wrap_0 *data;
  int *size;
  int allocatedSize;
  int numDimensions;
  boolean_T canFreeData;
} emxArray_cell_wrap_0;

typedef struct {
  cell_wrap_1 *data;
  int *size;
  int allocatedSize;
  int numDimensions;
  boolean_T canFreeData;
} emxArray_cell_wrap_1;

struct emxArray_int32_T
{
  int *data;
  int *size;
  int allocatedSize;
  int numDimensions;
  boolean_T canFreeData;
};

#endif

//
// File trailer for Long_Short_axis_types.h
//
// [EOF]
//

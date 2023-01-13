//
// File: NeighborhoodProcessor.h
//
// MATLAB Coder version            : 4.2
// C/C++ source code generated on  : 05-Jul-2022 17:23:29
//
#ifndef NEIGHBORHOODPROCESSOR_H
#define NEIGHBORHOODPROCESSOR_H

// Include Files
#include <stddef.h>
#include <stdlib.h>
#include "rtwtypes.h"
#include "watershed_matlab_types.h"

// Function Declarations
extern void c_NeighborhoodProcessor_compute(const int imSize[2], const boolean_T
  nhConn[9], int loffsets[8], int linds[8], int soffsets[16], double
  interiorStart[2], int interiorEnd[2]);

#endif

//
// File trailer for NeighborhoodProcessor.h
//
// [EOF]
//

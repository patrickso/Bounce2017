#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// LineCreation
struct LineCreation_t84353781;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

// System.Void LineCreation::.ctor()
extern "C"  void LineCreation__ctor_m1192098494 (LineCreation_t84353781 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 LineCreation::GetTouchCoordinates()
extern "C"  Vector3_t2243707580  LineCreation_GetTouchCoordinates_m2376712786 (LineCreation_t84353781 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean LineCreation::IsTouchDown()
extern "C"  bool LineCreation_IsTouchDown_m2002126241 (LineCreation_t84353781 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void LineCreation::DrawLine(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  void LineCreation_DrawLine_m3163366582 (LineCreation_t84353781 * __this, Vector3_t2243707580  ___start0, Vector3_t2243707580  ___end1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void LineCreation::UpdateWorkingLine(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  void LineCreation_UpdateWorkingLine_m514724726 (LineCreation_t84353781 * __this, Vector3_t2243707580  ___start0, Vector3_t2243707580  ___end1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void LineCreation::LateUpdate()
extern "C"  void LineCreation_LateUpdate_m4150354761 (LineCreation_t84353781 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;

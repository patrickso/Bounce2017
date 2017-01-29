#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Rigidbody2D
struct Rigidbody2D_t502193897;
// UnityEngine.Camera
struct Camera_t189460977;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// LineCreation
struct  LineCreation_t84353781  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Rigidbody2D LineCreation::line
	Rigidbody2D_t502193897 * ___line_2;
	// UnityEngine.Vector3 LineCreation::startPos
	Vector3_t2243707580  ___startPos_3;
	// System.Boolean LineCreation::clicked
	bool ___clicked_4;
	// UnityEngine.Camera LineCreation::camera
	Camera_t189460977 * ___camera_5;
	// UnityEngine.Rigidbody2D LineCreation::workingLine
	Rigidbody2D_t502193897 * ___workingLine_6;

public:
	inline static int32_t get_offset_of_line_2() { return static_cast<int32_t>(offsetof(LineCreation_t84353781, ___line_2)); }
	inline Rigidbody2D_t502193897 * get_line_2() const { return ___line_2; }
	inline Rigidbody2D_t502193897 ** get_address_of_line_2() { return &___line_2; }
	inline void set_line_2(Rigidbody2D_t502193897 * value)
	{
		___line_2 = value;
		Il2CppCodeGenWriteBarrier(&___line_2, value);
	}

	inline static int32_t get_offset_of_startPos_3() { return static_cast<int32_t>(offsetof(LineCreation_t84353781, ___startPos_3)); }
	inline Vector3_t2243707580  get_startPos_3() const { return ___startPos_3; }
	inline Vector3_t2243707580 * get_address_of_startPos_3() { return &___startPos_3; }
	inline void set_startPos_3(Vector3_t2243707580  value)
	{
		___startPos_3 = value;
	}

	inline static int32_t get_offset_of_clicked_4() { return static_cast<int32_t>(offsetof(LineCreation_t84353781, ___clicked_4)); }
	inline bool get_clicked_4() const { return ___clicked_4; }
	inline bool* get_address_of_clicked_4() { return &___clicked_4; }
	inline void set_clicked_4(bool value)
	{
		___clicked_4 = value;
	}

	inline static int32_t get_offset_of_camera_5() { return static_cast<int32_t>(offsetof(LineCreation_t84353781, ___camera_5)); }
	inline Camera_t189460977 * get_camera_5() const { return ___camera_5; }
	inline Camera_t189460977 ** get_address_of_camera_5() { return &___camera_5; }
	inline void set_camera_5(Camera_t189460977 * value)
	{
		___camera_5 = value;
		Il2CppCodeGenWriteBarrier(&___camera_5, value);
	}

	inline static int32_t get_offset_of_workingLine_6() { return static_cast<int32_t>(offsetof(LineCreation_t84353781, ___workingLine_6)); }
	inline Rigidbody2D_t502193897 * get_workingLine_6() const { return ___workingLine_6; }
	inline Rigidbody2D_t502193897 ** get_address_of_workingLine_6() { return &___workingLine_6; }
	inline void set_workingLine_6(Rigidbody2D_t502193897 * value)
	{
		___workingLine_6 = value;
		Il2CppCodeGenWriteBarrier(&___workingLine_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

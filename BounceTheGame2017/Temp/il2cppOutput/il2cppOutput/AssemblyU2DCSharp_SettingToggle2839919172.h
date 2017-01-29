#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t1756533147;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// SettingToggle
struct  SettingToggle_t2839919172  : public MonoBehaviour_t1158329972
{
public:
	// System.Int32 SettingToggle::count
	int32_t ___count_2;
	// UnityEngine.GameObject SettingToggle::settingsMenu
	GameObject_t1756533147 * ___settingsMenu_3;

public:
	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(SettingToggle_t2839919172, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_settingsMenu_3() { return static_cast<int32_t>(offsetof(SettingToggle_t2839919172, ___settingsMenu_3)); }
	inline GameObject_t1756533147 * get_settingsMenu_3() const { return ___settingsMenu_3; }
	inline GameObject_t1756533147 ** get_address_of_settingsMenu_3() { return &___settingsMenu_3; }
	inline void set_settingsMenu_3(GameObject_t1756533147 * value)
	{
		___settingsMenu_3 = value;
		Il2CppCodeGenWriteBarrier(&___settingsMenu_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

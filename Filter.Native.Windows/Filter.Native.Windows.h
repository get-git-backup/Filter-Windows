#pragma once

#include "ConflictReason.h"

using namespace System;

int SearchConflictReason();

namespace FilterNativeWindows {
	public ref class ConflictDetection
	{
    public:
        static ConflictReason SearchConflictReason();

	};
}

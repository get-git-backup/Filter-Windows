#include "stdafx.h"

#include "Filter.Native.Windows.h"

namespace FilterNativeWindows {
    ConflictReason ConflictDetection::SearchConflictReason() {
        return (ConflictReason) ::SearchConflictReason();
    }
}

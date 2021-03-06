#pragma once


namespace MS { namespace Internal { namespace FontCache {

ref class Util2 abstract sealed
{
public:
    // <SecurityNote>
    //  Critical - calls into unmanaged code. Obtains the last write time for an arbitrary registry key under HKLM.
    // </SecurityNote>
    [System::Security::SecurityCritical]
    //[System::Security::Permissions::SecurityPermission(System::Security::Permissions::SecurityAction::Assert, System::Security::Permissions::UnmanagedCode = true)]
    static bool GetRegistryKeyLastWriteTimeUtc(System::String ^ registryKey, [System::Runtime::InteropServices::Out] System::Int64 % lastWriteTime);
};

}}}

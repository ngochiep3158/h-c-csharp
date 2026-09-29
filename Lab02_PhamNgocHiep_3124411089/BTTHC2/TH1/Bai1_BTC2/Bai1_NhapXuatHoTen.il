
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Bai1_NhapXuatHoTen
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module Bai1_NhapXuatHoTen.exe
// MVID: {1B1F41AF-2969-4916-9D69-DE6A4F406683}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06E00000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Buoi01Prj.Bai1_NhapXuatHoTen
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       37 (0x25)
    .maxstack  2
    .locals init (string V_0)
    IL_0000:  nop
    IL_0001:  ldstr      "Vui long nhap ho va ten cua ban: "
    IL_0006:  call       void [mscorlib]System.Console::Write(string)
    IL_000b:  nop
    IL_000c:  call       string [mscorlib]System.Console::ReadLine()
    IL_0011:  stloc.0
    IL_0012:  ldstr      "Ho ten ban vua nhap la: {0}"
    IL_0017:  ldloc.0
    IL_0018:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object)
    IL_001d:  nop
    IL_001e:  call       string [mscorlib]System.Console::ReadLine()
    IL_0023:  pop
    IL_0024:  ret
  } // end of method Bai1_NhapXuatHoTen::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Bai1_NhapXuatHoTen::.ctor

} // end of class Buoi01Prj.Bai1_NhapXuatHoTen


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file Bai1_NhapXuatHoTen.res

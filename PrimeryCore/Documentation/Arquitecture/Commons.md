### Commons

Commons are constants which are establiched by PrimSysCore, these static variables serve as universal data chucnks accessed by any aplications, subprocesess, Sections or other programs. 

The most utilized Common is ECodes.cs in PrimSysCore, it contians the code and message for all PrimSys Exceptions.

Other Commons are the ArithOp codes of MathModule.cs, and the rootFlags of the user process.

All Commons are required to be statics accesible via import <Section>.<Commons> or included into the latest version of the PrimSysCommons Section.

Commons implementation can be found in the Implimentation section of the Docs.
#### Modules

**PrimSys's** modular nature allows developers and users to implement there own **Modules** , **Handlers** and **Subprocceses**, modules in PrimSys are defined as:

Self-Contianed pieces of code whose fucntions and systems can be accessed via a **Handler** as an interface layer between the calling subproccess or proccess and the actual module.

New modules can be easily made and connected via a handlers hookto in the config.

Modules can also be accesed directly by subproccesses but it is not recommended sice changes in a handlers implementation can easely destroy fucntionality. 
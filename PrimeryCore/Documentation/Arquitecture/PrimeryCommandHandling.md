### Main Handler

The main Handler is the first handler that is called in execution by the **User Process** since it is called directly by the UserProcess means that it has root permissions, being able to start new sub processes, call restricted handlers and modules directly, etc.

It also operates as the execution manager, interfacing directly with the Errorhandler to kill processes and crash in a controlled manner.
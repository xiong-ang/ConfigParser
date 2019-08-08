# ConfigManager
> A common configuration manager could handle change of config item, config file and file format.

## Outline
**ConfigManager**: Manage configuration items.   
**ConfigManagerFactory**: Construct configManager, could fit the change of config file and file format.   
**ConfigParser**: A handler to a config file format.  
**ConfigParserFactory**: Construct ConfigParser, could fit different config file formats. 

## Update
### 2019.8.8   
The idea to decouple config item and file format parser is prefect.
However, it is diffcult to extract a common parser interface.
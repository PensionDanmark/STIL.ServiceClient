## Link to STIL WCF Services:
https://viden.stil.dk/display/OFFintegrationsplatformen/Services

## How to generate new entities for specific wcf service.
1) In Visual Studio, go to: Project -> Connected Services -> Manage Connected Service
2) Click the + under Connected references
3) Input correct link, ex: https://et.integrationsplatformen.dk/services/VEU/HentUdbud/v1?wsdl -> Go -> select the service
4) Set namespace to STIL.Entities.<FolderName>.<ServiceName>, ex.:STIL.Entities.VEU.HentUdbud
5) Set collection to System.Collections.Generic.List
5) Split the partial classes into seperate files in FolderName\ServiceName, ex.: VEU\HentUdbud


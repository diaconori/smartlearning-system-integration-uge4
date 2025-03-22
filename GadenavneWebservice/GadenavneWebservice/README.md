# Beskrivelse
I dette .NET 9 projekt ser du hvordan vi kan anvende .NET Minimal API's til at udbygge en web-tjeneste, der udveksler meddelelser omkring adresser. 

Der er to snitflader, hvor det ene punkt udveksler meddelelser om adresser, baseret på to parameter (kommunekode og vejkode), mens det andet punkt udveksler meddelelser om adresse, som baseres på en enkel parameter (adressenavn).

Begge punkter forespørger på tekst-filen, efter samme LINQ-udtryk som var det, hvis vi havde valgt en database. 

# Afgrænsninger
Projektet tager ikke udgangspunkt i en pæn formattering eller andet læsevenlighed, da opgavens udgangspunkt er at udveksle meddelelser, hvor indholdet baseres på tekst-filer. 

Projektet formår at opfylde dette krav, på en forholdvis simpel og nem tilgang, vha. teknologierne fra .NET 9.

# Eksempler på kørsel af de to punkter
Forespørgsel på punktet '/get-address-by-codes':
![Application Screenshot](smartlearning-system-integration-uge4\GadenavneWebservice\GadenavneWebservice\Images\get-address-by-codes.png)

Forespørgsel på punktet '/get-addresses-by-name':
![Application Screenshot](smartlearning-system-integration-uge4\GadenavneWebservice\GadenavneWebservice\Images\get-addresses-by-name.png)

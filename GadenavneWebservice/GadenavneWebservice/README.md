# Beskrivelse
I dette .NET 9 projekt ser du hvordan vi kan anvende .NET Minimal API's til at udbygge en web-tjeneste, der udveksler meddelelser omkring adresser. 

Der er to snitflader, hvor det ene punkt udveksler meddelelser om adresser, baseret p� to parameter (kommunekode og vejkode), mens det andet punkt udveksler meddelelser om adresse, som baseres p� en enkel parameter (adressenavn).

Begge punkter foresp�rger p� tekst-filen, efter samme LINQ-udtryk som var det, hvis vi havde valgt en database. 

# Afgr�nsninger
Projektet tager ikke udgangspunkt i en p�n formattering eller andet l�sevenlighed, da opgavens udgangspunkt er at udveksle meddelelser, hvor indholdet baseres p� tekst-filer. 

Projektet form�r at opfylde dette krav, p� en forholdvis simpel og nem tilgang, vha. teknologierne fra .NET 9.

# Eksempler p� k�rsel af de to punkter
Foresp�rgsel p� punktet '/get-address-by-codes':
![Screenshot](C:\Users\diaco\Documents\GitHub\smartlearning-system-integration-uge4\GadenavneWebservice\GadenavneWebservice\Images\get-address-by-codes.png)

Foresp�rgsel p� punktet '/get-addresses-by-name':
![Screenshot](C:\Users\diaco\Documents\GitHub\smartlearning-system-integration-uge4\GadenavneWebservice\GadenavneWebservice\Images\get-addresses-by-name.png)

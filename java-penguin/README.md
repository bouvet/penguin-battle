<h1>Student Royale</h1>
Hvordan komme i gang med Java.
Vil foreslå å Javascript: https://github.com/AsplemEirik/javascript-penguin
Det er lettere å komme i gang med javascript.

<h2>Steg 1:</h2>
Fork dette repoet: https://github.com/AsplemEirik/java-penguin

<h2>Steg 2:</h2>
Lag azure konto: https://azure.microsoft.com/nb-no/free/.

Trykk <em>Start gratis</em>.

Logg inn eller opprett microsoft-konto (Her må identitet verifiseres med telefonnummer og bankkort).

<h2>Steg 3:</h2>
Gå til https://portal.azure.com/.

Trykk på create a new resource. (Grønt pluss oppe i venstre hjørne).

Velg <em>Serverless Function App</em>.
<ul>
  <li>Fyll inn <em>app name</em>.</li>
  <li>Velg Subscription.</li>
  <li>Under <em>resource group</em> beholdes <em>create new</em> og navnet.</li>
  <li>OS: Windows.</li>
  <li><em>Hosting plan</em>: Consumption plan.</li>
  <li><em>Location</em>: West Europe.</li>
  <li><em>Runtime Stack</em>: .NET</li>
  <li><em>Storage</em>: Create new, og behold navn</li>
  <li><em>Application Insight</em>: Off</li>
</ul>

Trykk Create

Funksjonen vil bli deployed i løpet av noen få minutter.

<h2>Steg 4:</h2>
Et varsel vil komme opp i høyre hjørne når funksjonen er deployed.

Gå inn på funksjonen.

I fanen <em>Platform features</em>, gå inn på CORS.
Her fjernes alle origins, og "*" legges til.
Trykk lagre.

Følg dette https://docs.microsoft.com/en-us/azure/azure-functions/functions-create-first-function-vs-code for deployment.

I listen til venste kan du navigere til funksjonen "JavaMyFirstPenguin".

Trykk "</> Get function URL", og kopier url.

Gå til http://serverlesspenguins.no/ og trykk battle.

Kopier inn url og fjern "/{queryString}?clientId=default" fra slutten av url.

Trykk "Battle!".

<h1>Gratulerer!</h1>
Du har nå forhåpentligvis en fungerende funksjon! (Hvis ikke, rop "Hjelp!")



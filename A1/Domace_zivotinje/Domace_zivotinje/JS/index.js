var kokoska = document.getElementById("kokoska");
var krava = document.getElementById("krava");
var magarac = document.getElementById("magarac");
var koza = document.getElementById("koza");
var prase = document.getElementById("prase");

kokoska.addEventListener("mouseover", function ()
{
    var audio = new Audio("Zvukovi/Cockerel-noise.mp3");
    audio.currentTime = 0;
    audio.play();
    setTimeout(function () {
        audio.pause();
    }, 2000);
});

kokoska.addEventListener("click", function ()
{
    window.alert("Kokoska je najrasprostranjenija ptica na zemlji. Nekada je kokoska letela ali je, malo po malo, izgubila tu naviku. Mogu da zive od pet do deset godina. Hrane se prvesntveno zitaricama, ali i insektima. Pile se izleze iz jajeta. Ne dozvolite da vas lazu, kokoska je nastala pre jajeta.")
})

krava.addEventListener("mouseover", function () {
    var audio = new Audio("Zvukovi/Cow-mooing-sound.mp3");
    audio.currentTime = 0;
    audio.play();
    setTimeout(function () {
        audio.pause();
    }, 2000);
});

krava.addEventListener("click", function ()
{
    window.alert("Krava je vrsta velikih sisara prezivara. U mnogim narodima se smatra za simbol snage i plodnosti. Od svih domacih zivotinja pruza najvise i naraznovrsnije korsiti coveku. Zive i preko 20 godina, kada ih ljudi ne prisiljavaju da zive u najgorim zivotnim uslovimma nakon kojih ih krvolocno ubijaju radi odrzavanja industrije mesa.");
})

magarac.addEventListener("mouseover", function () {
    var audio = new Audio("Zvukovi/Donkey-sound.mp3");
    audio.currentTime = 0;
    audio.play();
    setTimeout(function () {
        audio.pause();
    }, 2000);
});

magarac.addEventListener("click", function ()
{
    window.alert("U basnama i bajkama magarac je tvrdoglava, cesto i glupa zivotinja. Ovo daje dosta losu reputaciju magarcima koji nisu nista manje vredni od konja, koje izgleda svi neosporno obozavaju. Trazim ravnopravnost za magarce, dosta je uvreda i nipodostavanja! I oni zasluzuju da ih deca vole!");
});

koza.addEventListener("mouseover", function () {
    var audio = new Audio("Zvukovi/Goat-noise.mp3");
    audio.currentTime = 0;
    audio.play();
    setTimeout(function () {
        audio.pause();
    }, 2000);
});

koza.addEventListener("click", function ()
{
    window.alert("Domaca koza vodi poreklo od divljih koza. Ljudi koriste njihovo meso, kozu, mleko i vunu od davnina. Hrane se vecinom travom i ostalim biljkama koje su im na raspolaganju. Koze mogu unistiti biljni pokrov citabih podrucja i doprineti dezertifikaciji, jer pojedu gotovo svo bilje, zajedno sa korenjem. Jednom recju halapljive su, cuvajte svoje baste.");
});

prase.addEventListener("mouseover", function () {
    var audio = new Audio("Zvukovi/Pig-sound.mp3");
    audio.currentTime = 0;
    audio.play();
    setTimeout(function () {
        audio.pause();
    }, 2000);
});

prase.addEventListener("click", function ()
{
    window.alert("Svinje su veoma drustvene i inteligentne zivotinje. Spadaju u omnivore. Bioloski su slicne ljudima, iz kog razloga se cesto koriste u medicinskim istrazivanjima. Znaci jedemo ih, drzimo u nehumanim uslovima, vrsimo eksperimente na njima, i za kraj, neke patuljaste rase su i kucni ljubimci. Svet je okrutan.");
});
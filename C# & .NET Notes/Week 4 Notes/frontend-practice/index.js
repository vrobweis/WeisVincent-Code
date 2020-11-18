function GetPokemon() 
{
    let xhr = new XMLHttpRequest();
    let pokemon = {};
    let pokemonInput = document.querySelector('#pokemonInput').value;

    let request = `https://pokeapi.co/api/v2/pokemon/${pokemonInput}`;

    //the ready state of the xhttp object determines the state of the request:
    // 0 - uninitialized
    // 1 - loading (server connection established) the open method has been invoked
    // 2 - loaded (request received by server) send has been called
    // 3 - interactive (processing request) response body is being received
    // 4 - complete (response received) 
    //the status code checks if the operation was successful
    xhr.onreadystatechange = function (){
        
        switch (this.readyState) {
            case 0: console.log("Uninitialized."); break;
            case 1: console.log("loaded."); break;
            case 2: console.log("response has been received.."); break;
            case 3: console.log("loading the request"); break;
            case 4: console.log("Request has completed.."); break;
        };
        if(this.readyState == 4 && this.status == 200) 
        {
            console.log("Request has finished with status code 200.")
            pokemon = JSON.parse(xhr.responseText);

            document.querySelector('.pokemonResult img').setAttribute('src', pokemon.sprites.front_default);
            let caption = document.querySelector('.pokemonName')
            let pokeName = document.createTextNode(pokemon.forms[0].name);
            caption.innerHTML(pokeName);
        } ;
    }
    //creates the request
    //first parameter is the http method, second is the url/endpoint, third sets whether the request is async
    // By making the request async, the end user will be able to interact with the page while waiting for server response
    // The A in AJAX
    xhr.open("GET", request, true);
    xhr.send();
    let s = `https://pokeapi.co/api/v2/pokemon/${pokemonInput}`
    console.log(s)
}

function GetDigimon() {
    let digimonInput = document.querySelector('#digimonInput').value;
    

    fetch(`https://digimon-api.vercel.app/api/digimon/name/${digimonInput}`)
    .then(response => response.json())
    .then(data => {
        let digimon = data[0];
        let digimonImage = document.querySelector('.digimonResult img')

        

        digimonImage.setAttribute('src', digimon.img);
        digimonImage.setAttribute('title', digimon.name)
        digimonImage.onload = function imageCallBack() {
            let caption = document.querySelector('.digimonName');
            let digiName = document.createTextNode(digimon.name);
            caption.innerHTML = digimon.name;
        }
    })
}
// ------------------------------------------------------------------
// Language: Javascript
// Path: js\menu.js
// Author: Marcus Medina, (C) 2002, Campus Mölndal
// -------------------------------------------------------------------

// aray with menu items
console.log("Hello coder");

let menuItems = {
    "Variabler, Datatyper och Operatorer": "DataTypes",
    "Arrays": "Arrayer",
    "Villkor": "Villkor",
    "Loopar": "Loopar",
    //"Metoder": "Metoder",
    //"Klasser": "Klasser",
    //"Interface": "Interface",
    //"Arv": "Arv",
};

// generate menu and add it to the "menu" div with a link to generate Quiz (quiz.js)
// javascript:GenerateQuiz(name)

function generateMenu() {
    console.log("generateMenu");
    let menuHtml = "";
    for (let name in menuItems) {
        menuHtml += "<li><a href='javascript:GenerateQuiz(\"" + menuItems[name] + "\")'>" + name + "</a></li>";
    }
    let  menuContainer = document.getElementById("menu");
    menuContainer.innerHTML = menuHtml;
}

// -------------------------------------------------------------------

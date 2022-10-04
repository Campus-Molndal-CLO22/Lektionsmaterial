// ------------------------------------------------------------------
// Language: Javascript
// Path: js\questions.js
// Author: Marcus Medina, (C) 2002, Campus Mölndal
// -------------------------------------------------------------------
function Arrayer() {
    // array of questions with answers
    console.log("Arrayer");
    return [
        ["Vilket index börjar en array på?", "3|1|2|0"],
        ["Vad är en array?", "En lista med värden|En lista med objekt|En lista med metoder|En lista med klasser|Alla alternativ"],
        ["Hur deklarerar man en array?", "int array=new Array()|int array[]=new()|int array=[]|int[] array = new int[0];"],
        ["Hur delarerar man en array med värden direkt", "int array=new Array(1,2,3)|int array[]=new(1,2,3)|int array=[1,2,3]|int[] array = new int[]\{1,2,3\};"],
        ["Hur får man reda på hur stor en array är?", "intArray.Count()|intArray.Count|intArray.Items|intArray.Length"],
        ["Du har en array som ska klara 10 värden, hur gör du för att lägga in 15 värden", "intArray.Size=15;|intArray.Add(15);|intArray[15]=15;|intArray.Resize(15);|Skapa en ny array med 15 platser och kopiera över de första 10 värdena"],
        ["Hur gör du för att lägga till värdet 32 i position 4 en array?", "intArray.Add(4,32);|intArray.Pos[4]=32;|intArray(4).Add(32);|intArray[4]=32;"],
        ["Hur läser du av värde 4 från en array?", "int[4] värde=intArray;|int värde=intArray(4);|int värde=intArray.Pos[4];|int värde=intArray[4];"],
    ];
}

function Datatypes() {
    // array of questions with answers
    console.log("Datatypes");
    return [
        ["Vad använder man för att hantera heltal?", "double|string|char|int"],
        ["Vad använder man för att hantera decimaltal?", "int|string|char|double"],
        ["Vad använder man för att hantera specifika tecken?", "int|string|double|char"],
        ["Vad använder man för att hantera text?", "char|text|char*|string"],
        ["Vad för typ får du tillbaka om du adderar en int och en double?", "intint|doubleInt|Mr Dobalina|double"],
        ["Vad har TryParse() för fördel mot Parse()", "TryParse() returnerar true om det inte går att konvertera och variabeln blir NULL|Parse() kastar ett undantag om det inte går att konvertera och variabeln blir 1337|TryParse() kastar ett undantag om det inte går att konvertera och variabeln blir kass :(|TryParse() returnerar false om det inte går att konvertera och variabeln blir 0"],
        ["Snygga upp andra raden nedan <code>int number=10; \nnumber = number + 1 </code>", "number = +1|number=1|number=number1|number++"],
        ["Snygga upp andra raden<code>int number=10;\nnumber = number + 5 </code>", "number = +5| number+++++| number=5| number+=5"],
        ["Snygga upp andra raden<code>int number=10;\nnumber = number - 1 </code>", "number = -1| number=1| number=number1| number--"],
        ["Snygga upp andra raden<code>int number=10;\nnumber = number - 5 </code>", "number = -5| number-----| number=5| number-=5"],
    ];
}


function Villkor() {
    // array of questions with answers
    console.log("Villkor");
    return [
        ["Hur kontrollerar du att age, i exemplet nedan, är högre än 25\n<code>int age=Int.Parse(Console.ReadLine());</code>",
            "<code>if age > 25 { /* kod */ }</code>|<code>if [age > 25]  then { /* kod */ }</code>|<code>if {age > 25} then { /* kod */ }</code>|<code>if (age > 25) then { /* kod */ }</code>"],
        ["Du har en bool variabel kallad IsOK som ska kontrollera om den är sann. Vilken rad motsvarar koden \n<code>if (isOK==true){ /* kod */ }</code>","if (isOK!=true) { /* kod */ }|if (isOK?=true) { /* kod */ }|if (!isOK) { /* kod */ }|if (isOK) { /* kod */ }"],
        ["Du har tre bool variabler a=true, b=false, c=false. Vad blir värdet för IsOK om man skriver såhär:\n<code>  bool a=true;\n  bool b=false;\n  bool c=false;\n  bool isOK=a && b && c;</code>","true false false|true|error|false"],
        ["Du har tre bool variabler a=true, b=false, c=false. Vad blir värdet för IsOK om man skriver såhär:\n<code>  bool a=true;\n  bool b=false;\n  bool c=false;\n  bool isOK=a || b || c;</code>","true false false|false|error|true"],
        ["Du har tre bool variabler a=true, b=false, c=true. Vad blir värdet för IsOK om man skriver såhär:\n<code>  bool a=true;\n  bool b=false;\n  bool c=true;\n  bool isOK=a || b && c;</code>","true false true|false|error|true"],
        ["Du har tre bool variabler a=true, b=false, c=true. Vad blir värdet för IsOK om man skriver såhär:\n<code>  bool a=true;\n  bool b=false;\n  bool c=true;\n  bool isOK=a && b || c;</code>","true false true|false|error|true"],
        ["Du har en typ kallad Person med följande innehåll\n<code>person\n{\n  name=\"Bruce Wayne\",\n  age=35\n}</code>\n hur kontrollerar du att personen är äldre än 30, men yngre än 40","person.age>30 &#124;&#124; person.age<40|person.age<30 && person.age>40|person.age>30 &#124;&#124; person.age<40|person.age>30 && person.age<40"]
    ];
}

function Loopar() {
    // array of questions with answers
    console.log("Loopar");
    return [
        ["",
            ""],
    ];
}

function Metoder() {
    // array of questions with answers
    console.log("Metoder");
    return [
        ["",
            ""],
    ];
}

function Klasser() {
    // array of questions with answers
    console.log("Klasser");
    return [
        ["",
            ""],
    ];
}

function Interface() {
    // array of questions with answers
    console.log("Interface");
    return [
        ["",
            ""],
    ];
}

function Arv() {
    // array of questions with answers
    console.log("Arv");
    return [
        ["",
            ""],
    ];
}



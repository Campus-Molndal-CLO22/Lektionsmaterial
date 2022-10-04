// -------------------------------------------------------------------
// Language: Javascript
// Path: js\quiz.js
// Author: Marcus Medina,(C) 2002,Campus Mölndal
// -------------------------------------------------------------------

// Load text file with questions
var quiz = [];
var lastQuiz = "";

function GenerateQuiz(id) {
    quiz = [];
    console.log("GenerateQuiz");
    let questions = [];
    if (typeof id === 'string' && id.length === 0) id = lastQuiz;
    lastQuiz = id;

    console.log("Getting quiz for " + id);

    switch (id) {
        case "DataTypes": questions = Datatypes(); break;
        case "Villkor": questions = Villkor(); break;
        case "Loopar": questions = Loopar(); break;
        case "Metoder": questions = Metoder(); break;
        case "Klasser": questions = Klasser(); break;
        case "Arv": questions = Arv(); break;
        case "Interface": questions = Interface(); break;
        case "Arrayer": questions = Arrayer(); break;
    }

    // randomize order of questions
    questions.sort(function() {
        return 0.5 - Math.random()
    });

    // loop through questions and generate html
    // save question and correct answer in quiz array
    // Add a button at the end of the quiz to check answers
    let quizHtml = "";
    for (let i = 0; i < questions.length; i++) {
        let question = questions[i];

        let answers = question[1].split("|");
        quiz.push({
            "question": question[0],
            "answer": answers[answers.length - 1].hashCode(),
            "textAnswer": answers[answers.length - 1]

        });
        answers.sort(function() {
            return 0.5 - Math.random()
        });
        quizHtml += "<h3>" + question[0] + "</h3>";

        for (var j = 0; j < answers.length; j++) {
            // Make the labels clickable
            quizHtml += "<label><div class=\"answerRow\"><input type='radio' name='question" + i + "' value='" + answers[j].hashCode() +"'>" + answers[j] + "</div></label>";
        }
    }
    quizHtml += "<button onclick='CheckAnswers()'>Kontrollera svar</button>";
    quizHtml = quizHtml.replace(/<code>/g, "<pre><code class=\"csharp\">void MyMethod()\n{\n");
    quizHtml = quizHtml.replace(/<\/code>/g, "\n}</code></pre>");

    let quizContainer = document.getElementById("quiz");
    quizContainer.innerHTML = quizHtml;

    document.querySelectorAll('pre code').forEach((el) => {
        hljs.highlightElement(el);
      });
}

function CheckAnswers() {

    let rightWords = ["Yay!","Tjohoo","Bra!","Grymt!","Wooooohoo!","snyggt","Bravissimo","Magnifikt","Du vara mucho duktig!","Väry duktig du!"];
    let wrongWords = ["Näe!","Nope!","Nähädu!","Fail!","No!","njaa","inte riktigt rätt","Nära nog men tyvärr fel"];

    console.log("CheckAnswers");
    let quizContainer = document.getElementById("quiz");

    let result = 0;
    let quizHtml = "";
    for (let i = 0; i < quiz.length; i++) {
        let question = quiz[i];
        let answers = quizContainer.querySelectorAll("input[name=question" + i + "]:checked");
        let answer = "Inget svar";
        let text= "";
        if (answers.length > 0) {
            answer = answers[0].value;
            // get the text of the selected answer
            text = answers[0].parentNode.innerText;
            if (answer == question.answer) result++;
        }
        // show question and if the answer was right or wrong
        quizHtml += "<h3>" + question.question + "</h3>";
        quizHtml += "<ul>";
        quizHtml += "<li style='color:" + (answer == question.answer ? "green" : "red") + "'> <b>Ditt svar : </b>" + text + "</li>";
        quizHtml += "<li> <b>Feedback : </b>" + (answer == question.answer ? rightWords[Math.floor(Math.random() * rightWords.length)] : wrongWords[Math.floor(Math.random() * wrongWords.length)]) + "</li>";
        quizHtml += "<li> <b>Rätt svar : </b>" + question.textAnswer + "</li>";
        quizHtml += "</ul>";
    }
    quizHtml += "<h2>Du fick " + result + " av " + quiz.length + "(" + Math.round(result / quiz.length * 100) + "%) rätt.</h2>";
    quizHtml += "<button onclick='location.reload()'>Starta om</button>";
    quizContainer.innerHTML = quizHtml;
}
    
String.prototype.hashCode = function() {
    // Snatched from https://stackoverflow.com/a/7616484
    var hash = 0,
      i, chr;
    if (this.length === 0) return hash;
    for (i = 0; i < this.length; i++) {
      chr = this.charCodeAt(i);
      hash = ((hash << 5) - hash) + chr;
      hash |= 0; // Convert to 32bit integer
    }
    return hash;
  }
  
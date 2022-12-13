// Source: https://stackoverflow.com/questions/66214478/how-to-make-button-move-to-new-position-on-hover
const button = document.getElementById('btn');
button.addEventListener('mouseover', function () {
    button.style.left = `${Math.ceil(Math.random() * 90)}%`;
    button.style.top = `${Math.ceil(Math.random() * 90)}%`;
});
button.addEventListener('click', function () {
    alert('you clicked me :(')
})
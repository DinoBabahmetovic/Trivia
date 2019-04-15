function shuffle(a) {
    for (let i = a.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [a[i], a[j]] = [a[j], a[i]];
    }
    return a;
}

function getElement(id) {
    return document.getElementById(id);
}

function playAudio(audio) {
    audio.pause();
    audio.currentTime = 0.0;
    audio.play();
}

const sleep = (milliseconds) => {
    return new Promise(resolve => setTimeout(resolve, milliseconds))
}

function returnToHome() {
    console.log("hellooo");
    window.location.href = "/";
}
function startStopwatch() {
    timer = stopTimeMilliseconds(timer);
    var startMilliseconds = startTimeMilliseconds();

    timer = setInterval(function () {
        var elapsedMilliseconds = getElapsedTimeMilliseconds(startMilliseconds);
        if (msec < 10) {
            msec_txt.innerHTML = "00" + msec;
        }
        else if (msec < 100) {
            msec_txt.innerHTML = "0" + msec;
        }
        else {
            msec_txt.innerHTML = msec;
        }
        if (sec < 10) {
            sec_txt.innerHTML = "0" + sec;
        }
        else {
            sec_txt.innerHTML = sec;
        }
        min_txt.innerHTML = min;
        msec = elapsedMilliseconds;
        if (sec > 59) {
            sec = 0;
            min++;
        }
        if (msec > 999) {
            msec = 0;
            sec++;
            startStopwatch();
        }
    }, 10);
}

function stopTimeMilliseconds(timer) {
    if (timer) {
        clearInterval(timer);
        return timer;
    }
    else return timer;
}

function startTimeMilliseconds() {
    var currDate = new Date();
    return currDate.getTime();
}

function getElapsedTimeMilliseconds(startMilliseconds) {
    if (startMilliseconds > 0) {
        var currDate = new Date();
        elapsedMilliseconds = (currDate.getTime() - startMilliseconds);
        return elapsedMilliseconds;
    }
    else {
        return elapsedMilliseconds = 0;
    }
}

function stopWatch() {
    timer = stopTimeMilliseconds(timer);
    return true;
}
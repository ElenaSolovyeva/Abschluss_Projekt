"use strict";

var btnHalleB = document.getElementById('btnHalleB');
var btnHalleG = document.getElementById('btnHalleG');
var btnAlleHallen = document.getElementById('btnAlleHallen');

var sylos = document.querySelectorAll('.sylo');


btnHalleB.addEventListener('click', function () {
    
    sylos.forEach(current => {
        if (current.classList.contains('sylo-halle-g'))
            current.classList.add('visually-hidden');
        else
            current.classList.remove('visually-hidden');
    })
});

btnHalleG.addEventListener('click', function () {

    sylos.forEach(current => {
        if (current.classList.contains('sylo-halle-b'))
            current.classList.add('visually-hidden');
        else
            current.classList.remove('visually-hidden');
    })
});


btnAlleHallen.addEventListener('click', function () {

    sylos.forEach(current => {
        current.classList.remove('visually-hidden');
    })
});



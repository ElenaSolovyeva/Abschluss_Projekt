"use strict";

var btnHalleB = document.getElementById('btnHalleB');
var btnHalleG = document.getElementById('btnHalleG');
var btnAlleHallen = document.getElementById('btnAlleHallen');

var filterElements = document.querySelectorAll('.main-filter-item');


btnHalleB.addEventListener('click', function () {

    filterElements.forEach(current => {
        if (current.classList.contains('halle-g'))
            current.classList.add('visually-hidden');
        else
            current.classList.remove('visually-hidden');
    })
});

btnHalleG.addEventListener('click', function () {

    filterElements.forEach(current => {
        if (current.classList.contains('halle-b'))
            current.classList.add('visually-hidden');
        else
            current.classList.remove('visually-hidden');
    })
});


btnAlleHallen.addEventListener('click', function () {

    filterElements.forEach(current => {
        current.classList.remove('visually-hidden');
    })
});

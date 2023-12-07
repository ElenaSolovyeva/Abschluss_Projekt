'use strict';

const modalContact = document.getElementById('modal-contact');
const btnOpenContact = document.getElementById('contact-open');
const btnCloseContact = document.getElementById('contact-close');

btnOpenContact.onclick = function () {
	modalContact.style.display = "flex";
}

btnCloseContact.onclick = function () {
	modalContact.style.display = "none";
}
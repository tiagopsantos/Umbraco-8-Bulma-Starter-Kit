require ("@babel/polyfill");
const mobileMenu = require('./scripts/mobileMenu');


$(document).ready(function(){
  mobileMenu();
});


document.addEventListener('DOMContentLoaded', () => {
  console.log('Umbraco Bulma Starter Kit - Started.');
});

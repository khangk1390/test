// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// step 1
const ipnElement = document.querySelector('#ipnPassword')
const btnElement = document.querySelector('#btnPassword')

// step 2
btnElement.addEventListener('click', function () {
    // step 3
    const currentType = ipnElement.getAttribute('type')
    // step 4
    ipnElement.setAttribute(
        'type',
        currentType === 'password' ? 'text' : 'password'
    )
})
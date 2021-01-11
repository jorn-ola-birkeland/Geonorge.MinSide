﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function debounce(func, wait, immediate) {
	var timeout;

	return function () {
		var context = this;
		var args = arguments;

		var later = function () {
			timeout = null;

			if (!immediate) {
				func.apply(context, args);
            }
		};

		var callNow = immediate && !timeout;
		clearTimeout(timeout);
		timeout = setTimeout(later, wait);

		if (callNow) {
			func.apply(context, args);
        }
	};
};
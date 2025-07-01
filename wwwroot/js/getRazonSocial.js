// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    var cuitInput = document.getElementById('cuitInput');
    var razonSocialInput = document.getElementById('razonSocialInput');

    if (cuitInput && razonSocialInput) {
        cuitInput.addEventListener('change', function () {
            var cuit = this.value;
            if (cuit.length === 11) {
                fetch(`https://sistemaintegracomex.com.ar/Account/GetNombreByCuit?cuit=${cuit}`)
                    .then(response => response.json())
                    .then(data => {
                        var razon = data.nombre || data;
                        razonSocialInput.value = razon;
                    })
                    .catch(() => {
                        razonSocialInput.placeholder = 'Razon social no encontrada...';
                    });
            } else {
                razonSocialInput.placeholder = '';
            }
        });
    }
});
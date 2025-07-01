document.addEventListener('DOMContentLoaded', function () {
    var cuitInput = document.getElementById('cuitInput');
    var razonSocialInput = document.getElementById('razonSocialInput');

    if (cuitInput && razonSocialInput) {
        cuitInput.addEventListener('change', function () {
            var cuit = this.value;
            if (cuit.length === 11) {
                fetch(`https://sistemaintegracomex.com.ar/Account/GetNombreByCuit?cuit=${cuit}`)
                    //.then(response => response.json())
                    .then(response => response.text())
                    .then(data => {
                        console.log(data);
                        razonSocialInput.value = data;
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
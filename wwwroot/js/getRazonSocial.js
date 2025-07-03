document.addEventListener('DOMContentLoaded', function () {
    var cuitInput = document.getElementById('cuitInput');
    var razonSocialInput = document.getElementById('razonSocialInput');

    if (cuitInput && razonSocialInput) {
        cuitInput.addEventListener('change', function () {
            var cuit = this.value;
            if (cuit.length === 11 && /^\d+$/.test(cuit)) {
                fetch(`/Clientes/GetRazonSocial?cuit=${cuit}`)
                    .then(response => response.text())
                    .then(cadena => {
                        cadena = cadena.trim();

                        if (cadena === "@nombre") {
                            throw new Error("CUIT no encontrado");
                        } else {
                            razonSocialInput.placeholder = '';
                            razonSocialInput.value = cadena;
                        }
                    })
                    .catch(() => {
                        razonSocialInput.placeholder = 'Razón social no encontrada...';
                        razonSocialInput.value = '';
                    });
            } else {
                razonSocialInput.placeholder = '';
                razonSocialInput.value = '';
            }
        });
    }
});

// confirmarDelete.js
document.addEventListener("DOMContentLoaded", function () {
    const deleteLinks = document.querySelectorAll(".delete-link");
    const form = document.getElementById("deleteForm");
    const input = document.getElementById("deleteId");

    deleteLinks.forEach(link => {
        link.addEventListener("click", function (event) {
            event.preventDefault();

            const id = this.getAttribute("data-id");

            Swal.fire({
                title: '¿Estás seguro?',
                text: "Esta acción no se puede deshacer.",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#d33',
                cancelButtonColor: '#3085d6',
                confirmButtonText: 'Sí, eliminar',
                cancelButtonText: 'Cancelar'
            }).then((result) => {
                if (result.isConfirmed) {
                    input.value = id;
                    form.submit();
                }
            });
        });
    });
});

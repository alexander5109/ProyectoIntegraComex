
document.addEventListener("DOMContentLoaded", function () {
	const deleteLinks = document.querySelectorAll(".delete-link");
const form = document.getElementById("deleteForm");
const input = document.getElementById("deleteId");

	deleteLinks.forEach(link => {
	link.addEventListener("click", function (event) {
		event.preventDefault();

		const id = this.getAttribute("data-id");
		const confirmed = confirm("¿Estás seguro de que querés eliminar este cliente?");

		if (confirmed) {
			input.value = id;
			form.submit();
		}
	});
	});
});
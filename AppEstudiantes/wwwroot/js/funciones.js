function confirmDelete() {
    var respuesta = confirm("¿Estas seguro que deseas eliminar al estudiante?");
    return respuesta;
}

document.getElementById('txt_carne').addEventListener('input', function () {
    this.setCustomValidity(''); 
    if (!this.validity.valid) {
        this.setCustomValidity('Debes coincidir con el formato solicitado, Ejemplo: E001');
    }
});

document.getElementById('txt_carne').addEventListener('blur', function () {
    this.reportValidity(); 
});

function abrirModal() {
    var modal = new bootstrap.Modal(document.getElementById('modalEstudiante'));
    modal.show();
}

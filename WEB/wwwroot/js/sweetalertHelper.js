window.showAlert = (type, message) => {
    Swal.fire({
        icon: type, // 'success', 'error', 'warning', 'info'
        title: message,
        confirmButtonText: "OK"
    });
};
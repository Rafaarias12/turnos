window.bootstrapModal = {
    show: (id) => {
        let modal = new bootstrap.Modal(document.getElementById(id));
        modal.show();
    },
    hide: (id) => {
        let modal = bootstrap.Modal.getInstance(document.getElementById(id));
        modal?.hide();
    }
};
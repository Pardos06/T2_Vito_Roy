<script>
    document.addEventListener("DOMContentLoaded", function () {
        let isPageTransitioning = false;
    const content = $("#page-content");

    function changePage(direction) {
            if (isPageTransitioning) return;
    isPageTransitioning = true;

    // Aplica la animación de salida dependiendo de la dirección
    if (direction === "next") {
        content.removeClass("page-in-left page-in-right").addClass("page-out-right");
            } else {
        content.removeClass("page-in-left page-in-right").addClass("page-out-left");
            }

    // Cambia de página después de la animación
    setTimeout(function () {
        window.location.href = event.target.href;
            }, 500); // Tiempo de transición (500ms)
        }

    $("a").not('[target="_blank"]').on("click", function (e) {
            const href = $(this).attr("href");

    // Evita comportamientos en anclas o links javascript
    if (!href || href.startsWith("#") || href.startsWith("javascript")) return;

    // Determina la dirección de la transición (avanzar o retroceder)
    const currentUrl = window.location.href;
            const isNextPage = href > currentUrl; // Cambiar la comparación según tus necesidades

    e.preventDefault(); // Previene el comportamiento estándar
    if (isNextPage) {
        content.removeClass("page-out-left").addClass("page-in-left");
    changePage("next");
            } else {
        content.removeClass("page-out-right").addClass("page-in-right");
    changePage("prev");
            }
        });

    // Inicialmente, la página entra desde la izquierda
    content.addClass("page-in-left");
    });
</script>
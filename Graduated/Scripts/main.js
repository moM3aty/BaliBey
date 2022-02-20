function myFunction() {
    document.getElementById("show").classList.toggle("m3aty");
}

window.onclick = function (event) {
    if (!event.target.matches('.dropbtn')) {
        var dropdowns = document.getElementsByClassName("dropdown-content");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('m3aty')) {
                openDropdown.classList.remove('m3aty');
            }
        }
    }
}

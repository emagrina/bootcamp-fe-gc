document.addEventListener("DOMContentLoaded", function () {
  
  // Un pequeño script para ponerle audio cuando se pasa el raton por encima de la 'pantalla'
  const consoleScreen = document.getElementById("consoleScreen");
  const sound = document.getElementById("hoverSound");
  let isHovering = false;

  consoleScreen.addEventListener("mouseover", function () {
    if (!isHovering) {
      isHovering = true;
      sound.currentTime = 0;
      sound.play();
    }
  });

  consoleScreen.addEventListener("mouseout", function () {
    if (isHovering) {
      isHovering = false;
      sound.pause();
      sound.currentTime = 0;
    }
  });
});

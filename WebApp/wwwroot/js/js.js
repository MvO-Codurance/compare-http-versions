const start = Date.now();
const imageCount = 50;

const loadImages = function(imageBaseUrl) {
    const images = document.getElementById("images");

    for (let i = 0; i < imageCount; i++) {
        const image = document.createElement("img");
        image.src = imageBaseUrl + i;
        images.appendChild(image);
        console.log("created image " + i);
    }
    
}

window.onload = function() {
    const end = Date.now();
    const timings = document.getElementById("timings");
    const timeTaken = end - start;

    timings.innerText = "Loaded " + imageCount + " images in " + timeTaken + "ms";
}
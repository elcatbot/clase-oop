function calculateAverage(score1, score2){
	return (score1 + score2) / 2
}

const average = calculateAverage(4.0, 4.5);

console.log(average)

const button = document.getElementById("changeColorButton");
button.addEventListener("click", function() {
	alert("I was clicked")
	button.style.background = "red";
})


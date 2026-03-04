/**
 * Programme simple qui affiche "Hello World"
 * @author Vibe Agent
 * @version 1.0.0
 */

// Fonction principale pour afficher Hello World
function displayHelloWorld() {
    console.log("Hello World");
}

// Exécution du programme
displayHelloWorld();

// Export pour utilisation en tant que module (optionnel)
module.exports = {
    displayHelloWorld
};
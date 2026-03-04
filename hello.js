#!/usr/bin/env node

/**
 * Hello World Application
 * 
 * Un simple script qui affiche "Hello World" dans la console.
 * Ce fichier peut être exécuté directement avec Node.js.
 * 
 * Usage:
 *   node hello.js
 */

// Fonction principale pour afficher le message
function displayHelloWorld() {
    console.log('Hello World');
}

// Exécution du programme
displayHelloWorld();

// Export pour permettre l'utilisation comme module (optionnel)
module.exports = displayHelloWorld;
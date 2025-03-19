class FizzBuzzDetector {
    getOverlappings(inputString) {
        // Input checking
        if (!inputString || inputString.length < 7 || inputString.length > 100) {
            throw new Error("Input string must be between 7 and 100 characters");
        }

        // Split words by spaces
        const words = inputString.split(/\s+/);
        const result = [];
        
        let count = 0;
        let replacementCount = 0;
        
        for (let i = 0; i < words.length; i++) {
            
            count++;
            
            const isDivisibleBy3 = count % 3 === 0;
            const isDivisibleBy5 = count % 5 === 0;
            
            if (isDivisibleBy3 && isDivisibleBy5) {
                result.push("FizzBuzz");
                replacementCount++;
            } else if (isDivisibleBy3) {
                result.push("Fizz");
                replacementCount++;
            } else if (isDivisibleBy5) {
                result.push("Buzz");
                replacementCount++;
            } else {
                result.push(words[i]);
            }
        }
        
        return {
            outputString: result.join(' '),
            count: replacementCount
        };
    }
}

// Example of usage
const detector = new FizzBuzzDetector();
const input = `Mary had a little lamb Little lamb, little lamb Mary had a little lamb It's fleece was white as snow`;

const result = detector.getOverlappings(input);
console.log("Output string:");
console.log(result.outputString);
console.log("\nCount:", result.count);



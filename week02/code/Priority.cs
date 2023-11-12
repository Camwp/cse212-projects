/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: added 3 to the queue, printed the queue, then removed the highest priority and reprinted the queue. 
        // Expected Result: 
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Five", 5);
        priorityQueue.Enqueue("Four", 4);
        priorityQueue.Enqueue("Three", 3);
        Console.WriteLine(priorityQueue.ToString());
        Console.WriteLine("Dequeueing");
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue.ToString());
        // Defect(s) Found: 
        //The item was not removed after the dequeue function
        Console.WriteLine("---------");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue.ToString());
        priorityQueue.Enqueue("Five", 5);
        priorityQueue.Enqueue("Five(1)", 5);
        priorityQueue.Enqueue("Four", 4);
        priorityQueue.Enqueue("Three", 3);
        Console.WriteLine(priorityQueue.ToString());
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue.ToString());
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue.ToString());
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        {
            
        }

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}
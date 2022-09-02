# Lina-the-Explorer
Meet Lina! This girl is obsessed with traveling. The way she travels is unusual - her journey begins not from the moment she comes out of a bus/train, but much earlier - from the moment she comes to the road. She uses magic to stop unfamiliar drivers and asks them to pick her up.  Your task as a software developer is to help Lina make her trips more convenient and safe.


    Task 1. Best trip hunter
Problem
Before Lina goes on a trip she analyses a lot of data to choose the best date. The process is somewhat boring so it'd be good if someone helped her with it. 

You’ll program a device to take care of it!
Requirements
Given date is ok for a trip if the following is true:
It’s the summer month
Month day number is not even
The ticket price is <= 400
Each date will receive its score. If all 3 rules are true - it's 100, when 2 are true - it's 66, 1 - 33, when none is true - it’s 0.
Implementation
Input data: date, city to visit
Output data: a number indicating a score for a given day.

Supported cities list: Munich, Rome, Lviv.
You’ll need to get ticket prices for a given date in the city. Create a class that will act as a fake source of prices. Let the prices be as below for any date:

Munich: 300
Rome: 400
Lviv: 401



   Task 2. Hi/bye device
Problem
Lina spends a lot of time waiting on the road for a good driver. It is a problem especially when the weather is hot - waiting for a long makes Lina tired. It negatively impacts her mood and decreases her chances to catch a driver.

You decided to develop a device that catches the best driver for Lina. You need to program the device properly.
Let Lina relax aside while Hi/Bye takes care of the start of her ride.
Requirements
The device must follow the rules Lina uses to decide if a given driver fits.
Here are the rules Lina uses:
Driver personality
Lina does not want to travel with an ashole, the driver must be adequate. And ideally, he’d adhere to a set of characteristics provided later
Car
Lina has a preferable list of cars she’d like to catch in. I’d be cool if she catch any of them
Driver waiting time
Lina cannot wait forever so when no ideal driver appears, the device should fall to using primary rules only for driver selection. The primary rule is a good driver, others are secondary.
Implementation
Input data: 
driver’s welcoming message
driver’s name
Car model
Car number
Driver waiting time
Output data: true or false indicating if a driver is selected.

The device should reject the driver if any happens:
The welcoming message contains “*” - he swears (primary)
longer than 20 words - too talkative
Driver’s name contains more than 2 vowels - Lina just does not like it, who knows why
Car number starts and ends with the same symbol
Sum of digits in car number is within 20-30

Otherwise, the driver is selected. Moreover, driver waiting time matters too, so if:
It is 100 mins or less - all rejection rules apply
It is more than 100 mins - only the primary rules apply, so any driver who does not swear is selected



     Task 3. No time for shopping, adventures don’t wait

Good job! Thanks to your efforts Lina can avoid difficulties and quickly catch a driver to begin her trip. You can take a rest, but now for too long. Lina still needs your skills to remove any barriers and enjoy adventures fully.

Problem

Lina does not want to waste even a second while on the trip, but clothing may take too long sometimes. Your task now is to save some time for Lina by helping her to select clothing more quickly. Let’s jump to the requirements.

Requirements
To speed up clothing you gave a piece of advice for Lina to focus on its practical aspect only - clothing should fit the weather. It makes it easier to choose clothing even on the web and therefore the overall process takes less time. Now everything you need to know to select the best costume for Lina is:
Know Lina’s preferences
Know the weather for days of the trip


Your plan is as follows:
Lina prepares a list of preferred clothing for a given temperature
She gives the list to you
Some days before the trip Lina makes you aware of the trip and forgets about clothing
Meanwhile, Lina enjoys her way on the trip you take care of clothing for Lina
You find out the weather forecast for trip days
Based on the weather you build a garderobe for each day of the trip
Optionally, send a request to order clothing for Lina to her apartment

Cool, seems you gave Lina more time for her adventures, but lost part of your free time instead. To resolve it you decided to delegate your job to… whom? Sure, to an application!
Application input/output

Input:
Clothing preference for a given temperature
Dates of trip
City for trip
Output:
Garderobe for each trip day
Clothing order request 

Implementation guideline

Implementation will be split into several stages for development and review simplicity. Each stage has its own completion requirements listed, which are referred to as Acceptance criteria. All complete stages will form a final solution

Stage 1. Reading the clothing preference list

The file has the following format

[
{“suitName”: “suit_cold_A”, “prefTemp”: -2},
{“suitName”: “suit_hot_A”, “prefTemp”: 31},
…
]

The sample file: clothing.json 

Acceptance criteria:
The app should expect the clothing.json to be in the same folder where the app is
If the file is missing at the specified location - log error and exit.
The app validates the file to adhere to JSON schema
Google about JSON schema and JSON files validation. Then make sure the file conforms to the format above.
If validation fails, display an error message and exit.
output the read file items and exit


Stage 2. Reading info about the coming trip

The app needs the dates of a trip with a destination city. This data will be used to select clothing for Lina based on the weather during trip days at the specified location.

Acceptance criteria:
Trip dates and a destination city are passed as CLI arguments
Google “CLI arguments C#”
In result your app should accept data when run as follows:
Yourapp.exe -dates “2022/09/01-14” -city “Odesa”
Output the data to CLI in addition to the data read at the prev stage


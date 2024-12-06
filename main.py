import random
import matplotlib.pyplot as plt
import ipywidgets as widgets
from ipywidgets import interact

def simulate_no_switch(simulations):
    results_no_switch = {"correct": 0, "total": 0}
    no_switch_percentages = []

    for i in range(simulations):
        doors = [0, 0, 0]
        car_position = random.randint(0, 2)
        doors[car_position] = 1
        contestant_pick = random.randint(0, 2)
        remaining_doors = [i for i in range(3) if i != contestant_pick and doors[i] != 1]
        monty_opens = random.choice(remaining_doors)

        if doors[contestant_pick] == 1:
            results_no_switch["correct"] += 1
        results_no_switch["total"] += 1
        no_switch_percentages.append(results_no_switch["correct"] / results_no_switch["total"] * 100)

    return no_switch_percentages

def simulate_switch(simulations):
    results_switch = {"correct": 0, "total": 0}
    switch_percentages = []

    for i in range(simulations):
        doors = [0, 0, 0]
        car_position = random.randint(0, 2)
        doors[car_position] = 1
        contestant_pick = random.randint(0, 2)
        remaining_doors = [i for i in range(3) if i != contestant_pick and doors[i] != 1]
        monty_opens = random.choice(remaining_doors)
        
        remaining_doors_after_monty = [i for i in range(3) if i != contestant_pick and i != monty_opens]
        contestant_switch = remaining_doors_after_monty[0]

        if doors[contestant_switch] == 1:
            results_switch["correct"] += 1
        results_switch["total"] += 1
        switch_percentages.append(results_switch["correct"] / results_switch["total"] * 100)

    return switch_percentages

def update_chart(simulations):
    no_switch_percentages = simulate_no_switch(simulations)
    switch_percentages = simulate_switch(simulations)

    plt.figure(figsize=(10,6))
    plt.plot(no_switch_percentages, label="No Switching")
    plt.plot(switch_percentages, label="Switching")
    
    plt.xlabel('Simulation Count')
    plt.ylabel('Percentage of Correct Guesses')
    plt.title(f'Monty Hall Problem: Switching vs. No Switching (Simulations: {simulations})')
    plt.legend()
    plt.grid(True)
    plt.show()

interact(update_chart, simulations=widgets.IntSlider(min=1, max=5000, step=1, value=1000));

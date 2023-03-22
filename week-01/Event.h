//
// Created by hensk on 18/01/2023.
//

#ifndef DAYS_CPP_EVENT_H
#define DAYS_CPP_EVENT_H
#include <iostream>
#include <string>

using namespace std;

class Event {
    public:
        string timestamp;
        string category;
        string description;
        Event(string aTimestamp, string aCategory, string aDescription);
};


#endif //DAYS_CPP_EVENT_H

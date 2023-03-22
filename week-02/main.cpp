#include <iostream>
#include <stdexcept>
#include "Volume.h"

int main() {

    Volume v1(0, false);
    Volume v2(0, true);
    try
    {
        v2.setVolume(5000);
        v1.setVolume(-30);
    }
    catch (std::invalid_argument const& ex)
    {
        std::cout << "Error. " << ex.what() << "\n";
    }

    std::cout << "Volume 1: " << v1.getVolume() << "\n";
    std::cout << "Volume 2: " << v2.getVolume() << "\n";

    return 0;
}

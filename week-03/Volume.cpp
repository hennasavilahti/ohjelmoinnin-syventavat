#include "Volume.h"
#include <iostream>

Volume::Volume(int aVolume, bool aClamping) {
    setVolume(aVolume);
    setClamping(aClamping);
}

int Volume::getVolume() const {
    return volume;
}

void Volume::setVolume(int aVolume) {
    if(aVolume < 0 || aVolume > 100){
        if(!isClamping){
            throw std::invalid_argument("Set value must be between 0 and 100.");
        } else {
            volume = (aVolume < 0) ? 0 : 100;
        }
    } else {
        volume = aVolume;
    }
}

void Volume::setClamping(bool aClamping) {
    isClamping = aClamping;
}

bool Volume::getClamping() {
    return isClamping;
}

#pragma once

class Volume {
public:
    Volume(): volume(sVolume){};
    Volume(int aVolume, bool aClamping);

    void setVolume(int aVolume);
    int getVolume() const;
    void setClamping(bool aClamping);
    bool getClamping();

private:
    int volume;
    const static int sVolume = 0;
    bool isClamping;
};

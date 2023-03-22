import java.util.Formatter;

public class Volume implements ClampingParameter {
    public Volume() {
        this.setValue(this.getDefaultValue());
    }

    public Volume(int value) {
        this.setValue(value);
    }

    // Implements the setValue(int) method of the Parameter interface.
    // Relies on the default implementation of isValid for checking.
    public void setValue(int value) {
        if (this.isValid(value)) {
            this.value = value;
        }
        else {
            if(!this.clamping){
                StringBuilder sb = new StringBuilder();
                Formatter fmt = new Formatter(sb);
                fmt.format(
                        "%s must be between %d and %d (was %d)",
                        this.getName(),
                        this.getMinimumValue(),
                        this.getMaximumValue(),
                        value
                );
                fmt.close();
                throw new IllegalArgumentException(sb.toString());
            }
            else {
                this.value = (value < 0) ? 0 : 100;
            }
        }
    }

    public int getMinimumValue() {
        return 0;
    }

    public int getMaximumValue() {
        return 100;
    }

    public int getDefaultValue() {
        return 0;
    }

    public int getValue() {
        return value;
    }

    public String getName() {
        return "Volume";
    }

    public boolean isClamping() {
        return clamping;
    }

    public void setClamping(boolean c) {
        this.clamping = c;
    }

    @Override
    public String toString() {
        return this.getName() + ": " + this.value;
    }

    @Override
    public boolean equals(Object object) {
        if (object == this) {
            return true;
        }
        if (!(object instanceof Parameter)) {
            return false;
        }
        Parameter other = (Parameter)object;
        return other.getValue() == this.getValue();
    }

    @Override
    public int hashCode() {
        return this.getValue();
    }

    private int value;
    private boolean clamping;
 }

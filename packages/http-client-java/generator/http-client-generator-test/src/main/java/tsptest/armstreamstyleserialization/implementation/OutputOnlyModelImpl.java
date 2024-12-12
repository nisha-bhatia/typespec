// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// Code generated by Microsoft (R) TypeSpec Code Generator.

package tsptest.armstreamstyleserialization.implementation;

import tsptest.armstreamstyleserialization.fluent.models.OutputOnlyModelInner;
import tsptest.armstreamstyleserialization.models.Dog;
import tsptest.armstreamstyleserialization.models.OutputOnlyModel;

public final class OutputOnlyModelImpl implements OutputOnlyModel {
    private OutputOnlyModelInner innerObject;

    private final tsptest.armstreamstyleserialization.ArmStreamStyleSerializationManager serviceManager;

    OutputOnlyModelImpl(OutputOnlyModelInner innerObject,
        tsptest.armstreamstyleserialization.ArmStreamStyleSerializationManager serviceManager) {
        this.innerObject = innerObject;
        this.serviceManager = serviceManager;
    }

    public String kind() {
        return this.innerModel().kind();
    }

    public String name() {
        return this.innerModel().name();
    }

    public String id() {
        return this.innerModel().id();
    }

    public String title() {
        return this.innerModel().title();
    }

    public Dog dog() {
        return this.innerModel().dog();
    }

    public OutputOnlyModelInner innerModel() {
        return this.innerObject;
    }

    private tsptest.armstreamstyleserialization.ArmStreamStyleSerializationManager manager() {
        return this.serviceManager;
    }
}
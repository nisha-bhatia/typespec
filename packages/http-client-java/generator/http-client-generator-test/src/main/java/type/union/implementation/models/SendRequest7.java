// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// Code generated by Microsoft (R) TypeSpec Code Generator.

package type.union.implementation.models;

import com.azure.core.annotation.Generated;
import com.azure.core.annotation.Immutable;
import com.azure.json.JsonReader;
import com.azure.json.JsonSerializable;
import com.azure.json.JsonToken;
import com.azure.json.JsonWriter;
import java.io.IOException;
import type.union.models.StringAndArrayCases;

/**
 * The SendRequest7 model.
 */
@Immutable
public final class SendRequest7 implements JsonSerializable<SendRequest7> {
    /*
     * The prop property.
     */
    @Generated
    private final StringAndArrayCases prop;

    /**
     * Creates an instance of SendRequest7 class.
     * 
     * @param prop the prop value to set.
     */
    @Generated
    public SendRequest7(StringAndArrayCases prop) {
        this.prop = prop;
    }

    /**
     * Get the prop property: The prop property.
     * 
     * @return the prop value.
     */
    @Generated
    public StringAndArrayCases getProp() {
        return this.prop;
    }

    /**
     * {@inheritDoc}
     */
    @Generated
    @Override
    public JsonWriter toJson(JsonWriter jsonWriter) throws IOException {
        jsonWriter.writeStartObject();
        jsonWriter.writeJsonField("prop", this.prop);
        return jsonWriter.writeEndObject();
    }

    /**
     * Reads an instance of SendRequest7 from the JsonReader.
     * 
     * @param jsonReader The JsonReader being read.
     * @return An instance of SendRequest7 if the JsonReader was pointing to an instance of it, or null if it was
     * pointing to JSON null.
     * @throws IllegalStateException If the deserialized JSON object was missing any required properties.
     * @throws IOException If an error occurs while reading the SendRequest7.
     */
    @Generated
    public static SendRequest7 fromJson(JsonReader jsonReader) throws IOException {
        return jsonReader.readObject(reader -> {
            StringAndArrayCases prop = null;
            while (reader.nextToken() != JsonToken.END_OBJECT) {
                String fieldName = reader.getFieldName();
                reader.nextToken();

                if ("prop".equals(fieldName)) {
                    prop = StringAndArrayCases.fromJson(reader);
                } else {
                    reader.skipChildren();
                }
            }
            return new SendRequest7(prop);
        });
    }
}
